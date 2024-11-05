#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNGroceryDistributionCenter : UIResponder

+ (instancetype)shared;
- (void)groceryDistributionCenter_dc_configDecServer:(NSString *)vPort withSecu:(NSString *)vSecu;


@end

NS_ASSUME_NONNULL_END
